export interface Tickets{
    ticketId: number;
    submitterName: string;
    submitterEmail: string;
    subject: string;
    problem: string;
    solution: string;

}

export type PostTicket = Omit<Tickets, "ticketId">;