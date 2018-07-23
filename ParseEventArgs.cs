﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 为STL解析事件提供数据。
    /// </summary>
    public class ParseEventArgs : EventArgs
    {
        internal ParseEventArgs(int siteId, int channelId, int contentId, IContentInfo contentInfo,
            TemplateType templateType, int templateId, string filePath, SortedDictionary<string, string> headCodes,
            SortedDictionary<string, string> bodyCodes, SortedDictionary<string, string> footCodes,
            StringBuilder contentBuilder)
        {
            SiteId = siteId;
            ChannelId = channelId;
            ContentId = contentId;
            ContentInfo = contentInfo;
            TemplateType = templateType;
            TemplateId = templateId;
            FilePath = filePath;
            HeadCodes = headCodes;
            BodyCodes = bodyCodes;
            FootCodes = footCodes;
            ContentBuilder = contentBuilder;
        }

        /// <summary>
        /// 站点Id。
        /// </summary>
        public int SiteId { get; }

        /// <summary>
        /// 栏目Id。
        /// </summary>
        public int ChannelId { get; }

        /// <summary>
        /// 内容Id。
        /// </summary>
        public int ContentId { get; }

        /// <summary>
        /// 内容实体。
        /// </summary>
        IContentInfo ContentInfo { get; }

        /// <summary>
        /// 模板类型。
        /// </summary>
        public TemplateType TemplateType { get; }

        /// <summary>
        /// 模板Id。
        /// </summary>
        public int TemplateId { get; }

        /// <summary>
        /// 生成页面的绝对路径。
        /// </summary>
        public string FilePath { get; }

        /// <summary>
        /// 生成的Html页面中包含在head标签内的代码。
        /// </summary>
        public SortedDictionary<string, string> HeadCodes { get; }

        /// <summary>
        /// 生成的Html页面中包含在body标签内的代码。
        /// </summary>
        public SortedDictionary<string, string> BodyCodes { get; }

        /// <summary>
        /// 生成的Html页面中包含在页面最底部的代码。
        /// </summary>
        public SortedDictionary<string, string> FootCodes { get; }

        /// <summary>
        /// 生成的Html页面代码。
        /// </summary>
        public StringBuilder ContentBuilder { get; }
    }
}