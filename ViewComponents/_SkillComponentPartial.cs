﻿using Microsoft.AspNetCore.Mvc;
using My_Portfolio_Website.DAL.Context;

namespace My_Portfolio_Website.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
