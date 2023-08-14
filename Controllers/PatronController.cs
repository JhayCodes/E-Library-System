using asp.NetLibrary.Models.Patron;
using LibraryData;
using LibraryData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.NetLibrary.Controllers
{
    public class PatronController : Controller
    {
        private IPatron _patron;
        public PatronController(IPatron patron)
        {
            _patron = patron;
        }

        public IActionResult Index()
        {
            var allPatrons = _patron.GetAll();
            //when an patron is selected, a page is open with the selected patrons details
            var patronModels = allPatrons.Select(p => new PatronDetailModel
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                LibraryCardId = p.LibraryCard.Id,
                Address = p.Address,
                OverdueFees = p.LibraryCard.Fees,
                HomeLibraryBranch = p.HomeLibraryBranch.Name
            }).ToList();
            var model = new PatronIndexModel()
            {
                Patrons = patronModels
            };
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var patron = _patron.Get(id);
            var model = new PatronDetailModel
            {
                FirstName = patron.FirstName,
                LastName = patron.LastName,
                LibraryCardId = patron.LibraryCard.Id,
                Address = patron.Address,
                OverdueFees = patron.LibraryCard.Fees,
                HomeLibraryBranch = patron.HomeLibraryBranch.Name,
                MemberSince = patron.LibraryCard.Created,
                Telephone = patron.TelephoneNumber,
                AssetsCheckedOut = _patron.GetCheckOuts(id).ToList() ?? new List<Checkout>(),
                CheckoutHistory = _patron.GetCheckoutHistories(id),
                Holds = _patron.GetHolds(id)
            };
            return View(model);
  
        }
    }
}
