
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

  // userNames: Array<string>

  isFavorite: boolean
  ticketID: number
  tickets: any
}

// type userNames = Array<{text: string}>;

// const usersNames: string = [
//     {text: 'Kyle'},
//     {text: 'Corn'},
//     {text: 'Rachel'},
// ];


export type PutTicket = Omit<Users, "id">;
