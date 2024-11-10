using System;

namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            Tree tree = new ChristmasTree();

            TreeDecoratorWithOrnaments decoratedTree = new TreeDecoratorWithOrnaments();
            TreeDecoratorWithLights treeWithLights = new TreeDecoratorWithLights();

            decoratedTree.SetTree(tree); 
            treeWithLights.SetTree(decoratedTree); 

            treeWithLights.Display();

            Console.Read();
        }
    }

    // Component
    abstract class Tree
    {
        public abstract void Display();
    }

    // Ялинка без прикрас
    class ChristmasTree : Tree
    {
        public override void Display()
        {
            Console.WriteLine("Рiздвяна ялинка без прикрас");
        }
    }

    // "Decorator"
    abstract class TreeDecorator : Tree
    {
        protected Tree tree;

        public void SetTree(Tree tree)
        {
            this.tree = tree;
        }

        public override void Display()
        {
            if (tree != null)
            {
                tree.Display();
            }
        }
    }

    // Декоратор для прикрас
    class TreeDecoratorWithOrnaments : TreeDecorator
    {
        public override void Display()
        {
            base.Display();
            AddOrnaments();
        }

        private void AddOrnaments()
        {
            Console.WriteLine("Додано ялинковi прикраси");
        }
    }

    // Декоратор для гірлянди
    class TreeDecoratorWithLights : TreeDecorator
    {
        public override void Display()
        {
            base.Display();
            AddLights();
        }

        private void AddLights()
        {
            Console.WriteLine("Додано гiрлянду");
        }
    }
}
