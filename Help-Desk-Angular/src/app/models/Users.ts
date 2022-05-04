
//   export interface User{
//     ticketId: number;
//     priority: number;
//     assignedTo: string;
//     solution: string;
//     status: string;
//     resolvedTime: number;

// }

export interface Users {
  id: number
  userName: string
  isFavorite: boolean
  ticketID: number
  tickets: any
}

export type PutTicket = Omit<Users, "id">;