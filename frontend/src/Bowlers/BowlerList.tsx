import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';
import { BowlerCard } from './BowlerCard';

export function BowlerList() {
  const [bowlerList, setBowlerList] = useState<Bowler[]>([]);

  useEffect(() => {
    async function fetchBowlers() {
      const bowlerResponse = await fetch(
        'https://localhost:7105/BowlingLeague',
      );
      const bowlers = await bowlerResponse.json();

      setBowlerList(bowlers);
    }

    fetchBowlers();
  }, []);

  return (
    <>
      {bowlerList.map((bowlerItem: Bowler, index: number) => (
        <BowlerCard key={index} {...bowlerItem} />
      ))}
    </>
  );
}
