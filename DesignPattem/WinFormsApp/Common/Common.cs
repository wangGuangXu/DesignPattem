using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using WinFormsApp.Interface;

namespace WinFormsApp.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class Common
    {
        /// <summary>
        /// 获取插件列表
        /// </summary>
        /// <returns></returns>
        public static List<IExcutable> GetPlugins()
        {
            var iexcutables = new List<IExcutable>();

            //获取项目根目录下的Plugins文件夹
            string dir = GetPluginsDir();

            foreach (var file in Directory.GetFiles(dir + @"\", "*.dll"))
            {
                var asm = Assembly.LoadFrom(file);
                //遍历程序集中的类型
                foreach (var type in asm.GetTypes())
                {
                    //如果是IExcutable接口
                    if (type.GetInterfaces().Contains(typeof(IExcutable)))
                    {
                        //创建接口类型实例
                        var iExcutable =Activator.CreateInstance(type) as IExcutable;
                        if (iexcutables!=null)
                        {
                            iexcutables.Add(iExcutable);
                        }
                    }
                }
            }
            return iexcutables;
        }

        /// <summary>
        /// 从配置文件中获取插件所在目录
        /// </summary>
        /// <returns></returns>
        private static string GetPluginsDir()
        {
            return ConfigurationManager.AppSettings["pluginDir"];
        }

    }
}
