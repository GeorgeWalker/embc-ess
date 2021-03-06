export interface Person {
  id: string | null;
  active?: boolean; //no deletions from DB this is a soft delete.
  personType: string;  // --> 'VOLN' (volunteer), 'HOH' (head of household), 'FMBR' (family member)
  firstName: string;
  lastName: string;
  nickname: string;
  initials: string;
  gender: string;
  dob: Date | null;
}
