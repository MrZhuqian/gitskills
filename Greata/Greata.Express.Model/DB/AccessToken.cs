using System;
using System.ComponentModel.DataAnnotations;

namespace Greata.Express.Model.DB
{
    /// <summary>
    /// AccessToken数据实体
    /// </summary>
    public class AccessToken
    {
        /// <summary>
        /// Token字符串
        /// </summary>
        [Key]
        public string Token { get; set; }

        /// <summary>
        /// 相关用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 最近访问时间
        /// </summary>
        public DateTime LastAccess { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Created { get; set; }
    }
}
