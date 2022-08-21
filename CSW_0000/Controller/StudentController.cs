public class StudentController : Controller
{
    public JsonResult Get()
    {
        return Json(Repository.GetStudents());
    }
}
