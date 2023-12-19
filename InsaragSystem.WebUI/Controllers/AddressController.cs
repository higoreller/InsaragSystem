using InsaragSystem.Application.DTOs;
using InsaragSystem.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InsaragSystem.WebUI.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public async Task<IActionResult> Index()
        {
            var addresses = await _addressService.GetAddresses();
            return View(addresses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddressDTO addressDto)
        {
            if (ModelState.IsValid)
            {
                await _addressService.AddAddress(addressDto);
                return RedirectToAction(nameof(Index));
            }
            return View(addressDto);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var addressDto = await _addressService.GetAddressById(id);
            if (addressDto == null)
            {
                return NotFound();
            }
            return View(addressDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AddressDTO addressDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _addressService.UpdateAddress(addressDto);
                }
                catch (Exception)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(addressDto);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var addressDto = await _addressService.GetAddressById(id);
            if (addressDto == null)
            {
                return NotFound();
            }
            return View(addressDto);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _addressService.RemoveAddress(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var addressDto = await _addressService.GetAddressById(id);
            if (addressDto == null)
            {
                return NotFound();
            }
            return View(addressDto);
        }
    }
}
