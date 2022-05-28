﻿using Microsoft.EntityFrameworkCore;

namespace MultipleTableWebapi.Models
{
    public class OrderDbContext : DbContext
    {
        public  OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetails> ordersDetails { get; set; }  
    }
}
