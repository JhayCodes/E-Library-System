using asp.NetLibrary.Models.Catalog;
using asp.NetLibrary.Models.Checkout;
using LibraryData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.NetLibrary.Controllers
{
    public class CatalogController: Controller
    {
        private ILibraryAsset _assets;
        private ICheckout _checkouts;
        public CatalogController(ILibraryAsset assets, ICheckout checkouts)
        {
            _assets = assets;
            _checkouts = checkouts;
        }
        public IActionResult Index()
        {
            var assetModels = _assets.GetAll();
            var ListingResult = assetModels
                .Select(result => new AssetIndexListingModel
            {
                Id = result.Id,
                ImageUrl = result.ImageUrl,
                AuthorOrDirector = _assets.GetAuthorOrDirector(result.Id),
                DeweyCallNumber = _assets.GetDoweyIndex(result.Id),
                Title = result.Title,
                Type = _assets.GetType(result.Id)
            });

            var model = new AssetIndexModel()
            {
                Assets = ListingResult
            };
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var asset = _assets.GetById(id);
            var currentHolds = _checkouts.GetCurrentHolds(id)
                .Select(a => new AssetHoldModel
                {
                    HoldPlaced = _checkouts.GetCurrentHoldPlace(a.Id).ToString("d"),
                    PatronName = _checkouts.GetCurrentHoldPatronName(a.Id)

                });
            var model = new AssetDetailModel
            {
                AssetId = id,
                Title = asset.Title,
                Year = asset.Year,
                Cost = asset.Cost,
                Status = asset.Status.Name,
                ImageUrl = asset.ImageUrl,
                AuthorOrDirector = _assets.GetAuthorOrDirector(id),
                CurrentLocation = _assets.GetCurrentLocation(id).Name, 
                ISBN = _assets.GetIsbn(id),
                LatestCheckout = _checkouts.GetLatestCheckout(id),
                PatronName = _checkouts.GetCurrentCheckoutPatron(id),
                CurrentHolds = currentHolds,
                CheckoutHistories = _checkouts.GetCheckoutHistory(id)
            };
            
            return View(model);
        }
        public IActionResult Checkout(int id)
        {
            var asset = _assets.GetById(id);
            var model = new CheckoutModel
            {
                AssetId = id,
                ImageUrl = asset.ImageUrl,
                Title = asset.Title,
                LibraryCardId = " ",
                IsCheckOut = _checkouts.IsCheckedOut(id)
            };
            return View(model);
        }
        public IActionResult CheckIn(int id)
        {
            _checkouts.CheckInItem(id);
            return RedirectToAction("Detail", new { id = id });
        }
        public IActionResult MarkLost(int id)
        {
            _checkouts.MarkLost(id);
            return RedirectToAction("Detail", new { id = id});
        }
        public IActionResult MarkFound(int id)
        {
            _checkouts.MarkFound(id);
            return RedirectToAction("Detail", new { id = id });
        }
        public IActionResult Hold(int id)
        {
            var asset = _assets.GetById(id);
            var model = new CheckoutModel
            {
                AssetId = id,
                ImageUrl = asset.ImageUrl,
                Title = asset.Title,
                LibraryCardId = "",
                IsCheckOut = _checkouts.IsCheckedOut(id),
                HoldCount = _checkouts.GetCurrentHolds(id).Count()

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult PlaceCheckout(int assetId, int LibraryCardId)
        {
            _checkouts.CheckOutItem(assetId, LibraryCardId);
            return RedirectToAction("Detail", new { id = assetId }); 
        }

        [HttpPost]
        public IActionResult PlaceHold(int assetId, int LibraryCardId)
        {
            _checkouts.PlaceHold(assetId, LibraryCardId);
            return RedirectToAction("Detail", new { id = assetId });
        }
    }
}
