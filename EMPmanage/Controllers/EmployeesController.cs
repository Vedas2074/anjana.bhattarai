using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using EMPmanage.Datas;

public class EmployeesController : Controller
{
    private EMSContext db;
    public EmployeesController(EMSContext _db)
    {
        db = _db;
    }

    public ActionResult Index()
    {
        var employe = db.Staffs.ToList();

        return View(employe);
    }
    public ActionResult Details([FromQuery] int SN)
    {
        var employee = db.Staffs.Find(SN);
        return View(employee);

    }
    public ActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public ActionResult<string> Add(People people)
    {
        db.Staffs.Add(people);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));

    }
 public ActionResult Edit(int id)
    {
        var employee=db.Staffs.Find(id);
        return View(employee);
    }
[HttpPost]
public ActionResult Edit(People people)
    {
       db.Staffs.Attach(people);
       db.Staffs.Update(people);
       db.SaveChanges();
      return RedirectToAction(nameof(Index));
        
    }
    public ActionResult Delete(int Id)
    {
        var employee=db.Staffs.Find(Id);
        return View(employee);
    }
public ActionResult Delete(People people)
    {
        db.Staffs.Attach(people);
       db.Staffs.Remove(people);
       db.SaveChanges();
       return RedirectToAction(nameof(Index))   ;
        }


}
