﻿using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;

namespace MailSender.lib.Services
{
    public class RecipientsManager
    {
        private RecipientsStoreInMemory _Store;

        public RecipientsManager(RecipientsStoreInMemory Store) { _Store = Store; }


        public IEnumerable<Recipient> GetAll()
        {
            return _Store.Get();
        }

        public void Add(Recipient NewRecipient)
        {

        }

        public void Edit(Recipient Recipient)
        {
            _Store.Edit(Recipient.Id, Recipient);
        }
        // Delete(Recipient)

        public void SaveChanges()
        {
            _Store.SaveChanges();
        }
    }
}
