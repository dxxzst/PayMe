using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PayMe.Bussiness.Admin;

namespace PayMe.Controllers.Admin
{
    /// <summary>
    /// 实体操作模块
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        private readonly EntityBLL bll = new EntityBLL();
        private readonly IHostingEnvironment _hostingEnvironment;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        public EntityController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        /// <summary>
        /// 生成实体类
        /// </summary>
        /// <param name="entityName"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CreateEntity(string entityName = null)
        {
            if (entityName == null)
                return new JsonResult("参数为空");
            return new JsonResult(bll.CreateEntity(entityName, _hostingEnvironment.ContentRootPath));
        }
    }
}