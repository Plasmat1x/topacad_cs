using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassHierarchy
{
    struct vec2
    {
        int x;
        int y;
    }

    internal class Object
    {
        protected vec2 position;
        protected vec2 size;
        protected Image image;
        protected bool isDrawable;

        public void setSize(vec2 size)
        {
            this.size = size;
        }
        public void setPos(vec2 pos)
        {
            this.position = pos;
        }
        public void setImage(Image img)
        {
            this.image = img;
        }
        public void setDrawable(bool draw)
        {
            this.isDrawable = draw;
        }
    }

    internal class StaticObject : Object
    {
        protected bool isSolid;

        public void setSolid(bool solid)
        {
            this.isSolid = solid;
        }
    }

    internal class DynamicObject : Object
    {
        protected bool isMoveable;

        public void setMoveable(bool move)
        {
            this.isMoveable = move;
        }
    }

    internal class NPC : DynamicObject
    {
        enum States
        {
            IDLE,
            MOVE
        }

        private int hp;
        private bool quest;
        //etc

        //NPC methods, state tree
    }

    internal class Player : DynamicObject
    {
        enum States
        {
            IDLE,
            MOVE,
            ATTACK,
        }

        private int hp;
        //etc

        //Player methods, state tree, Controll
    }

    internal class Wall : StaticObject
    {
        //fields, methods
    }

    internal class Door : StaticObject
    {
        //fields, methods
    }

}
