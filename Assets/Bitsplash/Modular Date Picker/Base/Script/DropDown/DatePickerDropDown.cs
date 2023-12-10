using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Bitsplash.DatePicker
{
    /// <summary>
    /// this is a UI.Text implementation of the drop down
    /// </summary>
    public class DatePickerDropDown : DatePickerDropDownBase
    {
        public Text Label;
        public Text timeSelect;
        public GameObject oformButton;
        public GameObject bronButton;

        private void FixedUpdate()
        {
            if (Label.text == "--.--.----" || timeSelect.text == "")
            {
                bronButton.SetActive(false);
            }
            else
            {
                bronButton.SetActive(true);
            }
        }

        protected override void SetText(string text)
        {
            if (Label != null)
            {
                Label.text = text;
            }
        }
    }
}
