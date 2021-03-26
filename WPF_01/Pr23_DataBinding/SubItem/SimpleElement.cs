using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Globalization;

namespace Pr23_DataBinding.SubItem
{
    class SimpleElement:FrameworkElement
    {
        public static DependencyProperty NumberProperty; //自定义 DependencyProperty 变量

        public SimpleElement()
        {
            NumberProperty = DependencyProperty.Register("Number", typeof(double), typeof(SimpleElement),
                new FrameworkPropertyMetadata("0.0", FrameworkPropertyMetadataOptions.AffectsRender));
        }
        public double Number
        {
            set { SetValue(NumberProperty, value); }
            get { return (double)GetValue(NumberProperty); }
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(200, 50);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawText(new FormattedText(Number.ToString(),CultureInfo.CurrentCulture,FlowDirection.LeftToRight,
                new Typeface("Times New Roman"),12,SystemColors.WindowBrush), 
                new Point(0,0));
        }

    }
}
