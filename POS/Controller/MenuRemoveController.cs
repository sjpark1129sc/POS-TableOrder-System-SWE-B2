﻿using POS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain;

namespace POS.Controller
{
    public class MenuRemoveController
    {
        private MenuRepository menuRepository;

        public MenuRemoveController()
        {
            menuRepository = new MenuRepository();
        }
        public void MenuRemove(MenuEntity menu)
        {
            menuRepository.Delete(menu);
        }
    }
}
