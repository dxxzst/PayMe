using PayMe.Entity;
using PayMe.IService;
using PayMe.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PayMe.Service
{
    public class StudentService : BaseDB, IStudent
    {
        //private SqlSugarClient db = BaseDB.GetClient();
        public SimpleClient<Student> sdb = new SimpleClient<Student>(GetClient());

        #region base
        public TableModel<Student> GetPageList(int pageIndex, int pageSize)
        {
            PageModel p = new PageModel() { PageIndex = pageIndex, PageSize = pageSize };
            Expression<Func<Student, bool>> ex = (it => 1 == 1);
            List<Student> data = sdb.GetPageList(ex, p);
            TableModel<Student> t = new TableModel<Student>
            {
                Code = 0,
                Count = p.PageCount,
                Data = data,
                Msg = "成功"
            };
            return t;
        }

        public Student Get(long id)
        {
            return sdb.GetById(id);
        }

        public bool Add(Student entity)
        {
            return sdb.Insert(entity);
        }

        public bool Update(Student entity)
        {
            return sdb.Update(entity);
        }

        public bool Dels(dynamic[] ids)
        {
            return sdb.DeleteByIds(ids);
        }
        #endregion
    }
}
