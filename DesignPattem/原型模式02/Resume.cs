#region 文件注释
/* ===============================================
* 功能描述：Resume  
* 创 建 人：王光旭
* 创建日期：2014/12/31 14:47:42
* CLR版本：4.0.30319.18408
* 机器名称：WANGGUANGXU-PC
* 用户所在域：SEINCLUBANK
* 注册组织名：Microsoft
* 命名空间名称：原型模式02
* 当前登录用户名：WangGxu
* ================================================*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式02
{
    /// <summary>
    /// 简历
    /// </summary>
    public class Resume:ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private string timeArea;
        private string company;

        public Resume(string name)
        {
            this.name = name;
        }

        #region 设置个人信息
        /// <summary>
        /// 设置个人信息
        /// </summary>
        /// <param name="sex"></param>
        /// <param name="age"></param>
        public void SetPersonInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        } 
        #endregion

        #region 设置工作岗位
        /// <summary>
        /// 设置工作岗位
        /// </summary>
        /// <param name="timeArea"></param>
        /// <param name="company"></param>
        public void SetWorkExperience(string timeArea, string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        } 
        #endregion

        #region 显示
        /// <summary>
        /// 显示
        /// </summary>
        public void Display()
        {
            Console.WriteLine("{0},{1},{2}", name, sex, age);
            Console.WriteLine("工作经历:{0},{1}", timeArea, company);
        } 
        #endregion

        #region ICloneable 成员

        /// <summary>
        /// 克隆当前对象
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }

        #endregion

    }
}
