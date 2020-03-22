using Microsoft.EntityFrameworkCore;
using paybook.Models;

namespace paybook.Models
{
    //DbContext継承
    public class MyContext:DbContext
    {
        //コンストラクタ
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        //モデルクラスのアクセサー
        public DbSet<User> User { get; set; }
        //モデルクラスのアクセサー
        public DbSet<Pay> Pay { get; set; }
    }
}
