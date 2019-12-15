﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_4.User_Classes.Exceptions;

namespace Project_4.User_Classes
{
    class Event
    {
        private int id;
        private string title;
        private int category;
        private DateTime createdAt;
        private string description;
        private int duration;
        private bool status;

        public Event(int id)
        {
            this.id = id;
            enventDataSetTableAdapters.eventsTableAdapter ev = new enventDataSetTableAdapters.eventsTableAdapter();
            if(Convert.ToInt32(ev.tryEvent(this.id)) > 0)
            {
                List<enventDataSet.eventsRow> eventDetails =  ev.getEvent(this.id).ToList();
                this.title = eventDetails.ElementAt(0).title;
                this.category = eventDetails.ElementAt(0).category_id;
                this.createdAt = eventDetails.ElementAt(0).created_at;
                this.description = eventDetails.ElementAt(0).description;
                this.duration = eventDetails.ElementAt(0).duration;
                this.status = eventDetails.ElementAt(0).active;
            }
            else
            {
                throw new EventException("To event δεν υπάρχει.");
            }
        }

        public int GetID()
        {
            return id;
        }

        public string GetTitle()
        {
            return title;
        }

        public int GetCategory()
        {
            return category;
        }

        public DateTime GetCreatedAt()
        {
            return createdAt;
        }

        public string GetDescription()
        {
            return description;
        }

        public int GetDuration()
        {
            return duration;
        }

        public bool GetStatus()
        {
            return status;
        }

    }
}
