using System.Net;
using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Areas.Conventions.Attachments;
using Frapid.Framework.Extensions;
using Frapid.WebsiteBuilder;
using Serilog;

namespace MixERP.HRM.Controllers.Services
{
    public class AttachmentController : FrapidController
    {
        [Route("dashboard/hrm/services/attachments")]
        [HttpPost]
        public ActionResult Post()
        {
            var area = new AreaRegistration();
            var allowed = FrapidConfig.GetAllowedUploadExtensions(this.Tenant);

            var uploader = new Uploader(Log.Logger, area, this.Request.Files, this.Tenant, allowed);

            try
            {
                string fileName = uploader.Upload();

                fileName = "/dashboard/hrm/services/attachments/" + fileName;

                return this.Ok(fileName);
            }
            catch (UploadException ex)
            {
                return this.Failed(ex.Message, HttpStatusCode.BadRequest);
            }
        }

        [Route("dashboard/hrm/services/attachments/{*path}")]
        public ActionResult AttachmentResult(string path)
        {
            int width = this.Request.QueryString["width"].To<int>();
            int height = this.Request.QueryString["height"].To<int>();

            path = path.Replace("dashboard/hrm/services/attachments", "");
            var loader = new Deserializer(this.Tenant, new AreaRegistration(), width, height, path);
            var attachment = loader.Get();

            if (attachment == null)
            {
                return this.HttpNotFound();
            }

            return new FileContentResult(attachment, "image/png");
        }
    }
}