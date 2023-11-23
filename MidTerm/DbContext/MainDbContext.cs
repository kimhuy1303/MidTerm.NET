using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class MainDbContext : DbContext
    {
        public DbSet<Car>? Cars { get; set; }
        public DbSet<Account>? Accounts { get; set; }
        public DbSet<Bill>? Bills { get; set; }
        public DbSet<BillInfo>? BillInfos { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Feature>? Features { get; set; }
        public DbSet<Fuel>? Fuels { get; set; }
        public DbSet<Location>? Locations { get; set; }
        public DbSet<Schedule>? Schedules { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=KIM\KIMHUY; Database=MidTerm.NET; Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>()
                .Property(b => b.Status)
                .HasDefaultValue("Trống");


            //Mỗi xe chỉ sử dụng 1 loại nhiên liệu, mỗi loại nhiên liệu được sử dụng cho nhiều xe
            modelBuilder.Entity<Car>()
                        .HasOne(e => e.Fuel)
                        .WithMany(f => f.Cars)
                        .HasForeignKey(l => l.FuelId);

            //Mỗi bill chỉ có 1 billInfo, Mỗi billInfo chỉ thuộc 1 bill
            modelBuilder.Entity<BillInfo>()
                        .HasOne(e => e.Bill)
                        .WithOne(l => l.BillInfo)
                        .HasForeignKey<BillInfo>(r => r.BillId)
                        .IsRequired();

            //Mỗi Khách hàng có thể có nhiều bill, mỗi bill chỉ thuộc về 1 khách hàng
            modelBuilder.Entity<Customer>()
                        .HasMany(e => e.BillInfos)
                        .WithOne(f => f.Customer)
                        .HasForeignKey(r => r.CustomerId);

            //Mỗi tài khoản chỉ được phân một chức vụ, mỗi chức vụ đuọc phân cho nhiều tài khoản
            modelBuilder.Entity<Account>()
                        .HasOne(e => e.Role)
                        .WithMany(f => f.Account)
                        .HasForeignKey(r => r.RoleId);

            //Mỗi Bill chỉ được thuê 1 chiếc xe, mỗi chiếc xe được thuê bởi nhiều bill
            modelBuilder.Entity<Car>()
                        .HasMany(e => e.BillInfos)
                        .WithOne(f => f.Car)
                        .HasForeignKey(l => l.CarId);

            //Mỗi hóa đơn thuê xe chỉ có 1 lịch trình cụ thể, mỗi lịch trình sẽ có trong nhiều hóa đơn
            modelBuilder.Entity<BillInfo>()
                        .HasOne(e => e.Schedule)
                        .WithMany(f => f.BillInfos)
                        .HasForeignKey(l => l.ScheduleId);

            modelBuilder.Entity<Location>()
                        .HasMany(e => e.BillInfos)
                        .WithOne(f => f.Location)
                        .HasForeignKey(l => l.LocationId);
        }
    }
}
