using UGame.Lobby.Repository.ing;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;

namespace UGame.Lobby.Service.Services.Home
{

    public class ActivityIpo : LobbyBaseIpo
    {
        /// <summary>
        /// 当前页码
        /// 默认1
        /// </summary>
        [RangeEx(1, int.MaxValue, "", "PageIndex must be a positive integer greater than 0.")]
        public int PageIndex { get; set; } = 1;
        /// <summary>
        /// 页大小
        /// 默认5
        /// </summary>
        [RangeEx(1, 5, "", "PageSize must be a correct integer between 1 and 5.")]
        public int PageSize { get; set; } = 5;
    }
    public class ActivityDto : IMapFrom<L_activity_langEO>, IMapFrom<L_activity_langPO>
    {

        /// <summary>
		/// 活动编码GUID
		/// </summary>
        public string ActivityID { get; set; }
        /// <summary>
        /// 语言代码
        /// </summary>
        [JsonIgnore]
        public string LangID { get; set; }
        /// <summary>
        /// 活动类型
        /// </summary>
        public int Kind { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 活动图片集合
        /// </summary>
        public List<string> Imgs { get; set; }
        /// <summary>
        /// 类型:0-位置1-图片2-html3-文字
        /// </summary>
        public int Mode { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string LinkUrl { get; set; }
        /// <summary>
        /// 排序（从小到大）
        /// </summary>
        [JsonIgnore]
        public int OrderNum { get; set; }
        /// <summary>
        /// 起始日期（默认2016-01-01）
        /// </summary>
        [JsonIgnore]
        public DateTime BeginDate { get; set; }
        /// <summary>
        /// 截止日期（默认2099-01-01）
        /// </summary>
        [JsonIgnore]
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 状态(0-无效1-有效)
        /// </summary>
        [JsonIgnore]
        public int Status { get; set; }
        /// <summary>
        /// 活动是否有效
        /// </summary>
        public bool IsValid { get; set; } = true;

        /// <summary>
        /// 活动背景图
        /// </summary>
        public string Img1 { get; set; }

        /// <summary>
        /// 活动logo
        /// </summary>
        public string Img2 { get; set; }

        /// <summary>
        /// 左侧图标
        /// </summary>
        public string Img3 { get; set; }

        /// <summary>
        /// 右侧图标
        /// </summary>
        public string Img4 { get; set; }

        public void MapFrom(L_activity_langEO source)
        {
            this.Imgs = new List<string>();
            if (!string.IsNullOrWhiteSpace(source.Img1))
                Imgs.Add(source.Img1);
            if (!string.IsNullOrWhiteSpace(source.Img2))
                Imgs.Add(source.Img2);
            if (!string.IsNullOrWhiteSpace(source.Img3))
                Imgs.Add(source.Img3);
            if (!string.IsNullOrWhiteSpace(source.Img4))
                Imgs.Add(source.Img4);
            if (!string.IsNullOrWhiteSpace(source.Img5))
                Imgs.Add(source.Img5);

            if (DateTime.UtcNow < BeginDate || DateTime.UtcNow > EndDate || source.Status != 1)
                this.IsValid = false;
        }

        public void MapFrom(L_activity_langPO source)
        {
            this.Imgs = new List<string>();
            if (!string.IsNullOrWhiteSpace(source.Img1))
                Imgs.Add(source.Img1);
            if (!string.IsNullOrWhiteSpace(source.Img2))
                Imgs.Add(source.Img2);
            if (!string.IsNullOrWhiteSpace(source.Img3))
                Imgs.Add(source.Img3);
            if (!string.IsNullOrWhiteSpace(source.Img4))
                Imgs.Add(source.Img4);
            if (!string.IsNullOrWhiteSpace(source.Img5))
                Imgs.Add(source.Img5);

            if (DateTime.UtcNow < BeginDate || DateTime.UtcNow > EndDate || source.Status != 1)
                this.IsValid = false;
        }
    }
}
