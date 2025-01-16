//using UGame.Lobby.Service.Commands.Activity;
//using Microsoft.AspNetCore.Mvc.Filters;
//using AiUo.Logging;

//namespace UGame.Lobby.WebAPI.Filter
//{
//    /// <summary>
//    /// 
//    /// </summary>
//    public class CustomActionFilterAttribute : Attribute, IActionFilter
//    {

//        //构造函数注入1：创建只读私有私有属性

//        private readonly ILogger<CustomActionFilterAttribute> _logger;



//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="logger"></param>
//        public CustomActionFilterAttribute()
//        {
//            this._logger = LogUtil.CreateLogger<CustomActionFilterAttribute>(); ;
//        }

//        public void OnActionExecuted(ActionExecutedContext context)
//        {
            
//        }

//        public void OnActionExecuting(ActionExecutingContext context)
//        {
//            if (context.ActionArguments != null)
//            {
//                var ipo = context.ActionArguments.Values.FirstOrDefault();
//                var userId = GetPropertyValue(ipo, "UserId");
//                if (!userId.Equals(context.HttpContext.User?.Identity?.Name))
//                {
//                    throw new CustomException("非法请求");
//                }
//            }

//        }

//        public static string GetPropertyValue(object? info, string field)
//        {
//            if (info == null) return null;
//            Type t = info.GetType();
//            IEnumerable<System.Reflection.PropertyInfo> property = from pi in t.GetProperties() 
//                                                                    where pi.Name.ToLower() == field.ToLower() 
//                                                                   select pi;
//            if (property != null && property.Any())
//            {
//                var ret = property.FirstOrDefault()?.GetValue(info, null);
//                if (ret == null)
//                    return string.Empty;
//                else
//                    return ret.ToString();
//            }
//            return string.Empty;

//        }


//    }
//}
