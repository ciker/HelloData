﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace HelloData.FrameWork.Utils
{
    /// <summary>
    /// 数据检验类，如数字，数组等的信息检查
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// 判断对象是否为Int32类型的数字
        /// </summary>
        /// <param name="Expression">要判断的对象</param>
        /// <returns>是否为Int32类型</returns>
        public static bool IsNumeric(object expression)
        {
            if (expression != null)
                return IsNumeric(expression.ToString());

            return false;

        }

        /// <summary>
        /// 判断对象是否为Int32类型的数字
        /// </summary>
        /// <param name="Expression">要判断的对象</param>
        /// <returns>是否为Int32类型</returns>
        public static bool IsNumeric(string expression)
        {
            if (expression != null)
            {
                string str = expression;
                if (str.Length > 0 && str.Length <= 11 && Regex.IsMatch(str, @"^[-]?[0-9]*[.]?[0-9]*$"))
                {
                    if ((str.Length < 10) || (str.Length == 10 && str[0] == '1') || (str.Length == 11 && str[0] == '-' && str[1] == '1'))
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 是否为Double类型
        /// </summary>
        /// <param name="obj">要判断的对象</param>
        /// <returns>是否为Double类型</returns>
        public static bool IsDouble(object obj)
        {
            if (obj != null)
                return Regex.IsMatch(obj.ToString(), @"^([0-9])[0-9]*(\.\w*)?$");

            return false;
        }

        /// <summary>
        /// 判断给定的字符串数组(strNumber)中的数据是不是都为数值型
        /// </summary>
        /// <param name="strNumber">要确认的字符串数组</param>
        /// <returns>是则返加true 不是则返回 false</returns>
        public static bool IsNumericArray(string[] strNumber)
        {
            if (strNumber == null)
                return false;

            if (strNumber.Length < 1)
                return false;

            foreach (string id in strNumber)
            {
                if (!IsNumeric(id))
                    return false;
            }
            return true;
        }
    }
}