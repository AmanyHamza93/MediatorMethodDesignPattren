using MediatorMethodDesignPattren;

IChatMediator mediator = new ChatMediator();

User user1 = new User(mediator, " Alice ");
User user2 = new User(mediator, " Bob ");
User user3 = new User(mediator, " Charlie ");

user1.SendMessage(" Hello, everyone!");