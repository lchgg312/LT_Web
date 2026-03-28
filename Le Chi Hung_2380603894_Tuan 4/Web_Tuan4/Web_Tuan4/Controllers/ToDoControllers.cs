using Microsoft.AspNetCore.Mvc;
using Web_Tuan4.Models;

namespace DanhSachCongViec.Controllers
{
    public class TodoController : Controller
    {
        private static List<TodoItem> _items = new List<TodoItem>
        {
            new TodoItem { Id = 1, TenCongViec = "Đi chợ", IsHoanThanh = true },
            new TodoItem { Id = 2, TenCongViec = "Chơi thể thao", IsHoanThanh = false },
            new TodoItem { Id = 3, TenCongViec = "Chơi game", IsHoanThanh = false },
            new TodoItem { Id = 4, TenCongViec = "Học bài", IsHoanThanh = true },
        };

        public IActionResult Index() => View(_items);

        public IActionResult Details(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            return item == null ? NotFound() : View(item);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(TodoItem item)
        {
            item.Id = _items.Any() ? _items.Max(x => x.Id) + 1 : 1;
            _items.Add(item);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(TodoItem model)
        {
            var item = _items.FirstOrDefault(x => x.Id == model.Id);
            if (item != null)
            {
                item.TenCongViec = model.TenCongViec;
                item.IsHoanThanh = model.IsHoanThanh;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item == null) return NotFound();

            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _items.Remove(item);
            }
            return RedirectToAction("Index");
        }
    }
}