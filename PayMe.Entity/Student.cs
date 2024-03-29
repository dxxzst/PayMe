﻿
using SqlSugar;

namespace PayMe.Entity
{
    /// <summary>
    /// 学生实体
    /// </summary>
    [SugarTable("Student")]
    public class Student
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Tid { get; set; }
        /// <summary>
        /// 班级Id
        /// </summary>
        public int ClassId { get; set; }
        /// <summary>
        ///姓名
        /// </summary>
        public string Name { get; set; }
    }
}
