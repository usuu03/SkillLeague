export type Challenge = {
  id: string;
  title: string;
  description: string;
  category: string;
  imageUrl?: string;
  startDate: string; // ISO format string for DateTime
  endDate: string;
};
