﻿using UCosmic.Domain.People;

namespace UCosmic.Www.Mvc.Areas.My.Controllers
{
    public class UpdateEmailValueServices
    {
        public UpdateEmailValueServices(
            IProcessQueries queryProcessor
            , IHandleCommands<UpdateMyEmailValueCommand> commandHandler
        )
        {
            QueryProcessor = queryProcessor;
            CommandHandler = commandHandler;
        }

        public IProcessQueries QueryProcessor { get; private set; }
        public IHandleCommands<UpdateMyEmailValueCommand> CommandHandler { get; private set; }
    }
}