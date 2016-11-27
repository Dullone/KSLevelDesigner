using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace KSlevelDesigner
{
    class TextEvent
    {
        List<TileNode> activationNodes;
        string eventID;
        string _text;
        Color paintColor;
        double duration;
        Vector2 startLocation;
        Vector2 endLocation;
        public enum MovementType { linear, sin };
        MovementType movementType;

        public TextEvent(string eventName, string text, Color color, double eventDuration, Vector2 startLoc, Vector2 endloc, MovementType moveType)
        {
            eventID = eventName;
            _text = text;
            paintColor = color;
            duration = eventDuration;
            startLocation = startLoc;
            endLocation = endloc;
            movementType = moveType;
        }

        #region Properties
        public string MovementTypeAsString
        {
            get { return Enum.GetName(typeof(MovementType), movementType); }
        }
        #endregion //Properties
    }
}
