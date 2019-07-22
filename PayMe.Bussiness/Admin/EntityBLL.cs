using PayMe.IService;
using PayMe.Model;
using PayMe.Service;

namespace PayMe.Bussiness.Admin
{
    public class EntityBLL
    {
        private readonly IEntity iService = new EntityService();

        public MessageModel<string> CreateEntity(string entityName, string contentRootPath)
        {
            string[] arr = contentRootPath.Split('\\');
            string baseFileProvider = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                baseFileProvider += arr[i];
                baseFileProvider += "\\";
            }
            string filePath = baseFileProvider + "PayMe.Entity";
            if (iService.CreateEntity(entityName, filePath))
                return new MessageModel<string> { Success = true, Msg = "生成成功" };
            else
                return new MessageModel<string> { Success = false, Msg = "生成失败" };
        }
    }
}
