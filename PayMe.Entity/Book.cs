using SqlSugar;

namespace Models
{
    ///<summary>
    ///Book表
    ///</summary>
    [SugarTable("Book")]
    public partial class Book
    {
        public Book()
        {
        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true)]
        public long Tid { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Title { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Writer { get; set; }

    }
}
