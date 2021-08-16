using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;

namespace DesktopTodo.Services
{
    class TransitionerHandler
    {
        public int SelectedSlide { get; set; }
        public List<TransitionerSlide> Slides { get; private set; }
        public TransitionerHandler()
        {
            SelectedSlide = 0;
            Slides = new List<TransitionerSlide>();
        }

        public void NextSlide()
        {
            if (SelectedSlide < Slides.Count - 1) SelectedSlide++;
            else SelectedSlide = 0;
        }

        public void PrevSlide()
        {
            if (SelectedSlide != 0) SelectedSlide--;
            else SelectedSlide = Slides.Count - 1;
        }

        public void AddSlideAndGo(UserControl page)
        {
            SelectedSlide = AddSlide(page);
        }

        public int AddSlide(UserControl page)
        {
            TransitionerSlide slide = new TransitionerSlide();
            slide.Content = page;
            slide.OpeningEffect = new TransitionEffect(TransitionEffectKind.FadeIn);

            Slides.Add(slide);
            return Slides.IndexOf(slide);
        }
    }
}
