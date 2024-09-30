using System;
using System.Diagnostics;
using System.Windows;
using Autofac;
using Autofac.Diagnostics;
using WPFTest.Models;
using WPFTest.ViewModels;
using static Autofac.Diagnostics.DefaultDiagnosticTracer;

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private IContainer Container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ContainerBuilder();

            // Register your services
            builder.RegisterType<ReservationBook>().As<IReservationBook>().SingleInstance();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MakeReservationViewModel>().AsSelf();
            builder.RegisterType<ReservationListingViewModel>().AsSelf();

            Container = builder.Build();

            // Create a tracer instance and figure out
            // what you want to do when a trace is ready
            // to be viewed.
            var tracer = new DefaultDiagnosticTracer();
            tracer.OperationCompleted += (sender, args) =>
            {
                Trace.WriteLine(args.TraceContent);
            };

            Container.SubscribeToDiagnostics(tracer);

            // Use the container to resolve instances of your services
            using (var scope = Container.BeginLifetimeScope())
            {
                var viewModel = scope.Resolve<MainViewModel>();
                MainWindow = new MainWindow
                {
                    DataContext = viewModel
                };
            }

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}