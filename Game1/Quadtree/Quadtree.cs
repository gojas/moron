using Microsoft.Xna.Framework;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public interface INode
{
    
}


namespace QuadTree
{

    public class QuadTreeObject
    {

        // public just for now, chill!
        public float positionX = 0;
        public float positionY = 0;
        public float width = 0;
        public float height = 0;

        public QuadTreeObject(float aPositionX, float aPositionY, float aWidth, float aHeight)
        {
            positionX = aPositionX;
            positionY = aPositionY;
            width = aWidth;
            height = aHeight;
        }

    }

    public class QuadTree
    {
        public const int MAX_OBJECTS = 10;
        public const int MAX_DEPTH = 4;

        private List<QuadTreeObject> objects = new List<QuadTreeObject>();
        private Rectangle bounds;

        private QuadTreeNode root;

        public QuadTree(Rectangle aBounds)
        {
            bounds = aBounds;

            root = new QuadTreeNode(bounds, 0);
        }

        public QuadTree insert(QuadTreeObject aObject)
        {
            root.insert(aObject);

            return this;
        }

        public QuadTree insertList(List<QuadTreeObject> objects)
        {
            foreach (var anObject in objects)
                insert(anObject);

            return this;
        }

        public List<QuadTreeObject> retrieve(QuadTreeObject aObject)
        {
            List<QuadTreeObject> objects = root.retrieve(aObject);

            if (objects.Count() > 0)
                objects.RemoveAt(0);

            return objects;
        }

        public void clear()
        {
            root.clear();
        }

    }

    public class QuadTreeNode : INode
    {
        //subnodes
        private List<QuadTreeNode> nodes = new List<QuadTreeNode>();

        // children
        private List<QuadTreeObject> children = new List<QuadTreeObject>();

        //read only
        Rectangle bounds;

        private int depth;

        private const int TOP_LEFT = 0;
        private const int TOP_RIGHT = 1;
        private const int BOTTOM_LEFT = 2;
        private const int BOTTOM_RIGHT = 3;

        public QuadTreeNode(Rectangle aBounds, int aDepth)
        {
            bounds = aBounds;
            depth = aDepth;
        }

        public void insert(QuadTreeObject aObject)
        {
            if (nodes.Count() > 0)
            {
                var index = findIndex(aObject);

                nodes[index].insert(aObject);

                return;
            }

            children.Add(aObject);

            var len = children.Count();
            if (!(depth >= QuadTree.MAX_DEPTH) &&
                    len > QuadTree.MAX_OBJECTS)
            {

                divide();

                for (int i = 0; i < len; i++)
                {
                    insert(children[i]);
                }
                
                children.Clear();
            }
        }

        public List<QuadTreeObject> retrieve(QuadTreeObject aObject)
        {
            if (nodes.Count() > 0)
            {
                var index = findIndex(aObject);

                return nodes[index].retrieve(aObject);
            }

            return children;
        }

        public void clear()
        {
            children.Clear();

            var len = nodes.Count();

            for (int i = 0; i < len; i++)
            {
                nodes[i].clear();
            }

            nodes.Clear();
        }

        private int findIndex(QuadTreeObject aObject)
        {
            var b = bounds;
            var left = (aObject.positionX > bounds.Location.X + bounds.Width / 2) ? false : true;
            var top = (aObject.positionY > bounds.Location.Y + bounds.Height / 2) ? false : true;

            //top left
            var index = TOP_LEFT;
            if (left)
            {
                //left side
                if (!top)
                {
                    //bottom left
                    index = BOTTOM_LEFT;
                }
            }
            else
            {
                //right side
                if (top)
                {
                    //top right
                    index = TOP_RIGHT;
                }
                else
                {
                    //bottom right
                    index = BOTTOM_RIGHT;
                }
            }

            return index;
        }

        private void divide()
        {
            depth++;

            var bx = bounds.Location.X;
            var by = bounds.Location.Y;

            //floor the values
            var b_w_h = (bounds.Width / 2); //todo: Math.floor?
            var b_h_h = (bounds.Height / 2);
            var bx_b_w_h = bx + b_w_h;
            var by_b_h_h = by + b_h_h;

            //top left
            nodes.Insert(TOP_LEFT, new QuadTreeNode(new Rectangle(bx, by, b_w_h, b_h_h), depth));

            //top right
            nodes.Insert(TOP_RIGHT, new QuadTreeNode(new Rectangle(bx_b_w_h, by, b_w_h, b_h_h), depth));

            //bottom left
            nodes.Insert(BOTTOM_LEFT, new QuadTreeNode(new Rectangle(bx, by_b_h_h, b_w_h, b_h_h), depth));

            //bottom right
            nodes.Insert(BOTTOM_RIGHT, new QuadTreeNode(new Rectangle(bx_b_w_h, by_b_h_h, b_w_h, b_h_h), depth));
        }

    }

    
}

