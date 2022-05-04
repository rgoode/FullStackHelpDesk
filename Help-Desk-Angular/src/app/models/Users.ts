
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
  userNames: Array<userNames>
  // userNames: string
  isFavorite: boolean
  ticketID: number
  tickets: any
}
type userNames = Array<{text: string}>;

const usersNames: string = [
    {id: 1, text: 'Kyle'},
    {id: 2, text: 'Corn'},
    {id: 3, text: 'Rachel'},
];


export type PutTicket = Omit<Users, "ticketId">;