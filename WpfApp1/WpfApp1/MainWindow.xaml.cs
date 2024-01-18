using C1.WPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private C1DragDropManager _dd;
        private List<ListBox> listBoxes = new List<ListBox>();
        private List<UserControl> userControls = new List<UserControl>();
        public MainWindow()
        {
            InitializeComponent();

            _dd = new C1DragDropManager();

            for (int i = 1; i <= 5; i++)
            {
                UserControl1 userControl = new UserControl1();
                area.Children.Add(userControl);
                userControls.Add(userControl);
            }

            foreach (UserControl1 userControl in userControls)
            {
                _dd.RegisterDropTarget(userControl.lb, true);
                listBoxes.Add(userControl.lb);
            }

            // Generate and populate ListBoxes with data
            foreach (ListBox lb in listBoxes)
            {
                foreach (Person p in Person.Generate(5))
                {
                    var personElement = new ContentPresenter();
                    personElement.Content = p.Name;
                    personElement.MouseLeftButtonUp += personElement_MouseEnter;
                    personElement.ContentTemplate = (DataTemplate)Resources["StudentTemplate"];
                    lb.Items.Add(personElement);

                    _dd.RegisterDragSource(personElement, DragDropEffect.Move, ModifierKeys.None);
                    _dd.DragThreshold = 5;

                    personElement.MouseDown += (s, e) =>
                    {
                        e.Handled = true;
                    };
                }
            }

            // Subscribe to the DragDrop event
            _dd.DragDrop += _dd_DragDrop;
        }

        private void personElement_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Nhìn con cặc mà nhìn !!");
        }

        private void _dd_DragDrop(object source, DragDropEventArgs e)
        {
            // get object being dragged
            UIElement sourceElement = e.DragSource;
            // get source parent, target listboxes
            foreach (ListBox lb in listBoxes)
            {
                if (lb.Items.Contains(sourceElement))
                {
                    ListBox sourceParent = lb;
                    ListBox target = e.DropTarget as ListBox;
                    // get index into target
                    int index = GetDropIndex(e, target);
                    // adjust index
                    if (sourceParent == target)
                    {
                        int sourceIndex = sourceParent.Items.IndexOf(sourceElement);
                        if (index > sourceParent.Items.IndexOf(sourceElement))
                        {
                            index--;
                        }
                        if (index == sourceIndex)
                            return;
                    }
                    // remove from original position, insert into new position
                    sourceParent.Items.Remove(sourceElement);
                    target.Items.Insert(index, sourceElement);
                }
            }
            /*ListBox sourceParent = _list1.Items.Contains(sourceElement) ? _list1 : _list2;
            ListBox target = e.DropTarget as ListBox;
            // get index into target
            int index = GetDropIndex(e, target);
            // adjust index
            if (sourceParent == target)
            {
                int sourceIndex = sourceParent.Items.IndexOf(sourceElement);
                if (index > sourceParent.Items.IndexOf(sourceElement))
                {
                    index--;
                }
                if (index == sourceIndex)
                    return;
            }
            // remove from original position, insert into new position
            sourceParent.Items.Remove(sourceElement);
            target.Items.Insert(index, sourceElement);*/
        }

        private int GetDropIndex(DragDropEventArgs e, ListBox? target)
        {
            int index = 0;
            foreach (UIElement child in target.Items)
            {
                Point p = e.GetPosition(child);
                if (p.Y - child.DesiredSize.Height / 2 < 0) break;
                index++;
            }
            return index;
        }


    }
}
