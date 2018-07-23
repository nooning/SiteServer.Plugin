﻿using System;
using System.Collections.Generic;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 表单输入的验证规则类型。
    /// </summary>
    public class ValidateType : IEquatable<ValidateType>, IComparable<ValidateType>
    {
        /// <summary>
        /// 无验证。
        /// </summary>
        public static readonly ValidateType None = new ValidateType(nameof(None));

        /// <summary>
        /// 中文验证。
        /// </summary>
        public static readonly ValidateType Chinese = new ValidateType(nameof(Chinese));

        /// <summary>
        /// 英文验证。
        /// </summary>
        public static readonly ValidateType English = new ValidateType(nameof(English));

        /// <summary>
        /// Email格式验证。
        /// </summary>
        public static readonly ValidateType Email = new ValidateType(nameof(Email));

        /// <summary>
        /// 网址格式验证。
        /// </summary>
        public static readonly ValidateType Url = new ValidateType(nameof(Url));

        /// <summary>
        /// 电话号码验证。
        /// </summary>
        public static readonly ValidateType Phone = new ValidateType(nameof(Phone));

        /// <summary>
        /// 手机号码验证。
        /// </summary>
        public static readonly ValidateType Mobile = new ValidateType(nameof(Mobile));

        /// <summary>
        /// 整数验证。
        /// </summary>
        public static readonly ValidateType Integer = new ValidateType(nameof(Integer));

        /// <summary>
        /// 货币格式验证。
        /// </summary>
        public static readonly ValidateType Currency = new ValidateType(nameof(Currency));

        /// <summary>
        /// 邮政编码验证。
        /// </summary>
        public static readonly ValidateType Zip = new ValidateType(nameof(Zip));

        /// <summary>
        /// 身份证号码验证。
        /// </summary>
        public static readonly ValidateType IdCard = new ValidateType(nameof(IdCard));

        /// <summary>
        /// 正则表达式验证。
        /// </summary>
        public static readonly ValidateType RegExp = new ValidateType(nameof(RegExp));

        private ValidateType(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        /// <summary>
        /// 验证规则的值。
        /// </summary>
        public string Value { get; }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return Equals(obj as ValidateType);
        }

        /// <summary>
        /// 比较两个验证规则是否一致。
        /// </summary>
        /// <param name="a">需要比较的验证规则。</param>
        /// <param name="b">需要比较的验证规则。</param>
        /// <returns>如果一致，则为true；否则为false。</returns>
        public static bool operator ==(ValidateType a, ValidateType b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if ((object) a == null || (object) b == null)
            {
                return false;
            }

            return a.Equals(b);
        }
        /// <summary>
        /// 比较两个验证规则是否不一致。
        /// </summary>
        /// <param name="a">需要比较的验证规则。</param>
        /// <param name="b">需要比较的验证规则。</param>
        /// <returns>如果不一致，则为true；否则为false。</returns>
        public static bool operator !=(ValidateType a, ValidateType b)
        {
            return !(a == b);
        }
        /// <summary>
        /// 比较两个验证规则是否一致。
        /// </summary>
        /// <param name="other">需要比较的验证规则。</param>
        /// <returns>如果一致，则为true；否则为false。</returns>
        public bool Equals(ValidateType other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return
                Value.Equals(other.Value, StringComparison.OrdinalIgnoreCase);
        }
        /// <summary>
        /// 比较两个验证规则是否一致。
        /// </summary>
        /// <param name="other">需要比较的验证规则。</param>
        /// <returns>如果一致，则为0；否则为1。</returns>
        public int CompareTo(ValidateType other)
        {
            if (other == null)
            {
                return 1;
            }

            if (ReferenceEquals(this, other))
            {
                return 0;
            }

            return StringComparer.OrdinalIgnoreCase.Compare(Value, other.Value);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return EqualityComparer<string>.Default.GetHashCode(Value);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return Value;
        }
    }
}