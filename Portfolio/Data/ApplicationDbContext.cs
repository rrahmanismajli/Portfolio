using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace Portfolio.Data
{
    public class ApplicationDbContext :DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        } 
    }
}
