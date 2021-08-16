using DesktopTodo.Events;
using DesktopTodo.Services;
using DesktopTodo.Views;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DesktopTodo.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public WindowState WindowState { get; set; }
        public string Title { get; set; }
        public int SelectedSlide { get; set; }
        public ObservableCollection<TransitionerSlide> Slides { get; private set; }
        private EventBus _eventBus;
        public MainViewModel(EventBus eventBus)
        {
            _eventBus = eventBus;
            WindowState = WindowState.Normal;
            Slides = new ObservableCollection<TransitionerSlide>();
            SetPage(new LoginPage());

            _eventBus.Subscribe<NewPageEvent>(async page =>
            {
                SetPage(page.Page);
            });
        }

        public ICommand MinimizeWindow => new RelayCommand(o => 
        {
            WindowState = WindowState.Minimized;
        });
        public ICommand MaximizeWindow => new RelayCommand(o =>
        {
            if (WindowState == WindowState.Normal) WindowState = WindowState.Maximized;
            else if (WindowState == WindowState.Maximized) WindowState = WindowState.Normal;
        });
        public ICommand CloseWindow => new RelayCommand(window =>
        {
            (window as Window)?.Close();
        });

        private void SetPage(object page)
        {
            TransitionerSlide slide = new TransitionerSlide();
            slide.Content = page;
            slide.OpeningEffect = new TransitionEffect(TransitionEffectKind.FadeIn);

            Slides.Add(slide);
            SelectedSlide = Slides.IndexOf(slide);
        }

        /*
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
        */
    }
}
