using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketElevator.Models;

namespace RocketElevator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColumnsController : ControllerBase
    {
        private readonly RocketContext _context;

        public ColumnsController(RocketContext context)
        {
            _context = context;
        }

        // GET: api/Columns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Columns>>> GetColumns()
        {
            return await _context.Columns.ToListAsync();
        }

        // GET: api/Columns/10
        [HttpGet("{id}")]
        public async Task<ActionResult<Columns>> GetColumns(long id)
        {
            var columns = await _context.Columns.FindAsync(id);

            if (columns == null)
            {
                return NotFound();
            }

            return columns;
        }

        // Retrieving the current status of a specific Column
        // GET: api/Columns/{id}/status
        [HttpGet("{id}/Status")]
        public async Task<ActionResult<string>> GetColumnStatus([FromRoute] long id)
        {
            var cc = await _context.Columns.FindAsync(id);

            if (cc == null)
                return NotFound();
            Console.WriteLine("Get batterie status", cc.ColumnStatus);

            return cc.ColumnStatus;

        }

        // Get columns for specific Customers

        [HttpGet("{email}/column")]
        public IEnumerable<Columns> ColumnCostumer([FromRoute] string email)
        {


            var cost = _context.Customers.Where(c => c.CompanyContactEmail.Equals(email));
            Customers costume = cost.FirstOrDefault();
            // var costx = costume.Id;       


            IEnumerable<Columns> Col =
            (from col in _context.Columns
             join batteries in _context.Batteries on col.BatteryId equals batteries.Id
             where
             col.ColumnStatus == "ACTIVE"
             orderby batteries.CreatedAt
             select col).Take(3);
            return Col.Distinct().ToList();

        }

        // Changing the status of a specific Column
        [HttpPut("{id}/Status/")]
        public async Task<IActionResult> UpdateStatus([FromRoute] long id, Columns mycolumn)
        {

            if (id != mycolumn.Id)
            {
                return BadRequest();
            }

            if (mycolumn.ColumnStatus == "Active" || mycolumn.ColumnStatus == "Inactive" || mycolumn.ColumnStatus == "Intervention")
            {
                _context.Entry(mycolumn).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return Content("Column: " + mycolumn.Id + ", status has been changed to: " + mycolumn.ColumnStatus);
            }

            return Content("Please insert a valid status : Intervention, Inactive, Active, Tray again !  ");
        }




        // DELETE: api/Columns/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Columns>> DeleteColumns(long id)
        {
            var columns = await _context.Columns.FindAsync(id);
            if (columns == null)
            {
                return NotFound();
            }

            _context.Columns.Remove(columns);
            await _context.SaveChangesAsync();

            return columns;
        }

        private bool ColumnsExists(long id)
        {
            return _context.Columns.Any(e => e.Id == id);
        }
    }
}
