using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using NestedBorder.Annotations;

namespace NestedBorder
{
    /// <summary>
    /// Interaction logic for DoubleBorder.xaml
    /// </summary>
    public partial class DoubleBorder : INotifyPropertyChanged
    {
        public DoubleBorder()
        {
            DataContext = this;
            InitializeComponent();

            OuterBorderBrush = new SolidColorBrush(Colors.Red);
            InnerBorderBrush = new SolidColorBrush(Colors.Blue);
        }

        public Brush OuterBorderBrush { get; set; }

        public Brush InnerBorderBrush { get; set; }



        public Thickness OuterBorderThickness
        {
            get { return (Thickness)GetValue(OuterBorderThicknessProperty); }
            set { SetValue(OuterBorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OuterBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OuterBorderThicknessProperty =
            DependencyProperty.Register("OuterBorderThickness", typeof(Thickness), typeof(DoubleBorder), new PropertyMetadata(default(Thickness)));


        public Thickness InnerBorderThickness
        {
            get { return (Thickness)GetValue(InnerBorderThicknessProperty); }
            set { SetValue(InnerBorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OuterBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InnerBorderThicknessProperty =
            DependencyProperty.Register("InnerBorderThickness", typeof(Thickness), typeof(DoubleBorder), new PropertyMetadata(default(Thickness)));



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
