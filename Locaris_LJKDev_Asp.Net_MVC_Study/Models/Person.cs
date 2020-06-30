using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locaris_LJKDev_Asp.Net_MVC_Study.Models
{
    public class Person
    {
        //假定此类与数据库的某个表对应

        [Required(ErrorMessage = "LJK_编号不能为空！！")]
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(18,99,ErrorMessage ="LJK_必须是18-99之间的值！！" )]
        public string Age { get; set; }
        public string QQ { get; set; }
        public void Run()
        {

        }
    }

    //扩展方法
    public static class LJK
    {
        public static void Say(this Person person,string age)
        {
            person.Age = age;
        }
    }
}