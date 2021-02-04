using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RentVDB.Models
{
    // Vous pouvez ajouter des données de profil pour l'utilisateur en ajoutant d'autres propriétés à votre classe ApplicationUser. Pour en savoir plus, consultez https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Notez qu'authenticationType doit correspondre à l'élément défini dans CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Ajouter les revendications personnalisées de l’utilisateur ici
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private DbSet<Customer> _customers;
        private DbSet<MembershipType> _membershipTypes;
        private DbSet<Rental> _rentals;
        private DbSet<Genre> _genres;
        private DbSet<MovieMay> _movieMays;
        private DbSet<MovieFormViewModel> _movieFormViewModels;

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<RentVDB.Models.Customer> Customers
        {
            get => _customers;
            set => _customers = value;
        }

        public System.Data.Entity.DbSet<RentVDB.Models.MembershipType> MembershipTypes
        {
            get => _membershipTypes;
            set => _membershipTypes = value;
        }


        public System.Data.Entity.DbSet<RentVDB.Models.Rental> Rentals
        {
            get => _rentals;
            set => _rentals = value;
        }

        public System.Data.Entity.DbSet<RentVDB.Models.Genre> Genres
        {
            get => _genres;
            set => _genres = value;
        }

        public System.Data.Entity.DbSet<RentVDB.Models.MovieMay> MovieMays
        {
            get => _movieMays;
            set => _movieMays = value;
        }

        public System.Data.Entity.DbSet<RentVDB.Models.MovieFormViewModel> MovieFormViewModels
        {
            get => _movieFormViewModels;
            set => _movieFormViewModels = value;
        }
    }
}