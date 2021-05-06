using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaServico.Api.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [EnableCors("Cors")]
    public class AuthBaseController : ControllerBase
    {
    }
}
