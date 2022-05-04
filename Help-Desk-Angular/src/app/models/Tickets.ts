export interface Tickets {
    ticketID: number;
    submitterName: string;
    submitterEmail: string;
    subjectLine: string;
    problem: string;
    submittedTime: string;
    solution: string;
    priority: number;
    assignedTo: string;
    status: string;
    resolvedTime: string;
    users: any;
  }



export type PostTicket = Omit<Tickets, "ticketID">;