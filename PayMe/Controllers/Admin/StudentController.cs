﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PayMe.Bussiness.Admin;
using PayMe.Entity;

namespace PayMe.Controllers.Admin
{
    /// <summary>
    /// 学生模块
    /// </summary>
    [Produces("application/json")]
    [Route("api/admin/[controller]")]
    [Authorize(Policy="Admin")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentBLL bll = new StudentBLL();

        #region base
        /// <summary>
        /// 获取学生分页列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult GetStudentPageList(int pageIndex = 1, int pageSize = 10)
        {
            return new JsonResult(bll.GetPageList(pageIndex, pageSize));
        }
        /// <summary>
        /// 获取单个学生
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public JsonResult GetStudentById(long id)
        {
            return new JsonResult(bll.GetById(id));
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Add(Student entity = null)
        {
            if (entity == null)
                return new JsonResult("参数为空");
            return new JsonResult(bll.Add(entity));
        }
        /// <summary>
        /// 编辑学生
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Student")]
        public JsonResult Update(Student entity = null)
        {
            if (entity == null)
                return new JsonResult("参数为空");
            return new JsonResult(bll.Update(entity));
        }

        /// <summary>
        /// 删除学生
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpDelete]
        public JsonResult Dels(dynamic[] ids = null)
        {
            if (ids.Length == 0)
                return new JsonResult("参数为空");
            return new JsonResult(bll.Dels(ids));
        }
        #endregion
    }
}