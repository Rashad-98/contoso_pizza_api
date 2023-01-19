using Microsoft.EntityFrameworkCore;
using ContosoPizza.Models;

namespace ContosoPizza.Data;

public class PizzaContext : DbContext
{
    public PizzaContext(DbContextOptions<PizzaContext> options)
    : base(options)
    {
    }

    public DbSet<Pizza> pizzas => Set<Pizza>();
    public DbSet<Topping> toppings => Set<Topping>();
    public DbSet<Sauce> sauces => Set<Sauce>();
}