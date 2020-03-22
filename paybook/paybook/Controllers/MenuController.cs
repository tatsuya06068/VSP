using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using paybook.Models;


namespace paybook.Controllers
{
    
    public class MenuController : Controller
    {
        private bool flg;//ユーザー名、パスワードが合ってるか判定
        private static int userFlg = 0;//ログイン中か判定URL検索で入れなくするため



        public IActionResult UserConfirm(String userName, String password)
        {


            if (userName == "fht_0203") {
                if (password == "fht_0203") {
                    flg = true;

                }
                else {
                    flg = false;
                }
            }
            else
            {
                flg = false;
            }
            

            if (flg == true)
            {
                return Menu();
            }
            else
            {
                return LoginError();
            }
        }
        public IActionResult Menu()
        {
            userFlg = 1;
            return View("Menu");
        }

        public IActionResult LoginError()
    {
            ViewBag.eMessage= "ユーザー名かパスワードが間違っています。";
            return View("../Home/Login");
    }

    }
}