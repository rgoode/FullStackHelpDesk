
  export interface User{
    ticketId: number;
    priority: number;
    assignedTo: string;
    solution: string;
    status: string;
    resolvedTime: number;

}

export type PutTicket = Omit<User, "ticketId">;