
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (context.Posts.Count() == 0)
            {
                List<Post> seedPosts = new List<Post> {
                    new Post(){
                        Title= "First poster", Body= "Purrr purr littel cat, little cat purr purr steal mom's crouton while she is in the bathroom, you have cat to be kitten me right meow, hide head under blanket so no one can see. Murf pratt ungow ungow hunt anything stand in doorway, unwilling to chose whether to stay in or go out. Dont wait for the storm to pass, dance in the rain paw at beetle and eat it before it gets away found somthing move i bite it tail or good now the other hand, too pet me pet me pet me pet me, bite, scratch, why are you petting me. Suddenly go on wild-eyed crazy rampage. At four in the morning wake up owner meeeeeeooww scratch at legs and beg for food then cry and yowl until they wake up at two pm jump on window and sleep while observing the bootyful cat next door that u really like but who already has a boyfriend end up making babies with her and let her move in drink water out of the faucet yet spend all night ensuring people don't sleep sleep all day ptracy jump on counter removed by human jump on counter again removed by human meow before jumping on counter this time to let the human know am coming back. Hell is other people paw at your fat belly and open the door, let me out, let me out, let me-out, let me-aow, let meaow, meaow! yet i just saw other cats inside the house and nobody ask me before using my litter box so eat too much then proceed to regurgitate all over living room carpet while humans eat dinner, and i love cuddles or i will ruin the couch with my claws. Sit by the fire i’m so hungry i’m so hungry but ew not for that eat all the power cords ooooh feather moving feather! make muffins i like big cats and i can not lie. To pet a cat, rub its belly, endure blood and agony, quietly weep, keep rubbing belly scratch leg; meow for can opener to feed me. Steal the warm chair right after you get up the fat cat sat on the mat bat away with paws and dismember a mouse and then regurgitate parts of it on the family room floor and and sometimes switches in french and say \"miaou\" just because well why not. Ooh, are those your $250 dollar sandals? lemme use that as my litter box meow to be let out so show belly. Catch small lizards, bring them into house, then unable to find them on carpet break lamps and curl up into a ball peer out window, chatter at birds, lure them to mouth for the fat cat sat on the mat bat away with paws meowing non stop for food but eats owners hair then claws head. If it fits, i sits love fish for gimme attention gimme attention gimme attention gimme attention gimme attention gimme attention just kidding i don't want it anymore meow bye jump on human and sleep on her all night long be long in the bed, purr in the morning and then give a bite to every human around for not waking up request food, purr loud scratch the walls, the floor, the windows, the humans kitty run to human with blood on mouth from frenzied attack on poor innocent mouse, don't i look cute? for found somthing move i bite it tail. Stares at human while pushing stuff off a table. Pushed the mug off the table chase little red dot someday it will be mine! demand to have some of whatever the human is cooking, then sniff the offering and walk away i shall purr myself to sleep. Love fish russian blue scratch meow throw down all the stuff in the kitchen if human is on laptop sit on the keyboard so scratch at the door then walk away. "
                    },
                    new Post(){
                        Title= "Second post", Body= "Stinky cat steal raw zucchini off kitchen counter paw at your fat belly. Eat and than sleep on your face sleep on keyboard, but scratch ask to be pet then attack owners hand chew master's slippers catch mouse and gave it as a present i want to go outside let me go outside nevermind inside is better. Experiences short bursts of poo-phoria after going to the loo. Scratch my tummy actually i hate you now fight me i will ruin the couch with my claws i will ruin the couch with my claws or crash against wall but walk away like nothing happened drool. Furball roll roll roll cat is love, cat is life but lick sellotape but refuse to drink water except out of someone's glass for sleeping in the box, so howl on top of tall thing. Shed everywhere shed everywhere stretching attack your ankles chase the red dot, hairball run catnip eat the grass sniff. Hit you unexpectedly meow meow you are my owner so here is a dead rat, or hunt anything so cats are a queer kind of folk."
                    },
                    new Post(){
                        Title= "Third poster" , Body= "Stinky cat steal raw zucchini off kitchen counter paw at your fat belly. Eat and than sleep on your face sleep on keyboard, but scratch ask to be pet then attack owners hand chew master's slippers catch mouse and gave it as a present i want to go outside let me go outside nevermind inside is better. Experiences short bursts of poo-phoria after going to the loo. Scratch my tummy actually i hate you now fight me i will ruin the couch with my claws i will ruin the couch with my claws or crash against wall but walk away like nothing happened drool. Furball roll roll roll cat is love, cat is life but lick sellotape but refuse to drink water except out of someone's glass for sleeping in the box, so howl on top of tall thing. Shed everywhere shed everywhere stretching attack your ankles chase the red dot, hairball run catnip eat the grass sniff. Hit you unexpectedly meow meow you are my owner so here is a dead rat, or hunt anything so cats are a queer kind of folk. "
                    },
                };

                context.Posts.AddRange(seedPosts);

                context.SaveChanges();

            }
        }
    }
}