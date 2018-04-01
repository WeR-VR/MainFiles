using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour {

    // Use this for initialization
    public Text Page;
    public GameObject PageBG;
    private int PageCount = 0;


    void OnTriggerEnter(Collider collider)
    {
        //Using switch case for many other collectables like health, ammo, and other stuff

        //TODO: Added cases for ammo health packs and many other.
        switch(collider.gameObject.tag)
        {
            case "Page":
                {
                    Debug.Log("Collectables!!");
                    
                    switch(PageCount)
                    {
                        case 0:
                            {
                                //Just disableing not destoying.
                                collider.gameObject.SetActive(false);
                                PageBG.SetActive(true);
						Page.text = "Personal log Entry#1 \n" +
									"Shariff: Johnathan Doeff \n" +
							"Date: Fri, Mar 23 30## \n" +
							"GOD DAMMIT! \n" +
							"Not only have I been transferred to an outpost in the middle " +
							"of nowhere, they make me write logs in this data book, no one even " +
							"looks over theses things, its just busy work. \n" +
							"In any case since no one reads these things I might as well vent my frustrations" +
							" here, its not like there’s any crimes to stop in this town any way, the population barely" +
							" breaks fifty people, everyone knows each other and most of them are either middle aged or old.";
                                StartCoroutine(Wait());
                                PageCount++;
                                break;
                            }
                        case 1:
                            {
                                collider.gameObject.SetActive(false);
                                PageBG.SetActive(true);
						Page.text = "Personal log Entry#2\n" +
							"Shariff: Johnathan Doeff\n" +
							"Date: Fri, Mar 23 30##\n" +
							"This whole damn mess started when my superior told me I was getting a promotion, A MANDATORY PROMOTION, it was either take the promotion or get demoted," +
							" so I reluctantly took the promotion not know how soul crushing it would be.\n" +
							"Frist was I had to take my wife and move 5,000,000 light years away to some random fringe planet, than I was made sheriff of some god forsaken outpost where barely anything happens," +
							" and I some how get paid less even though this was supposed to be a promotion.\n" +
							"All this because the previous sheriff went missing, both he and his arbiter suit.\n" +
							"Well I cant really blame him, I have half a mind myself to get my wife and skip town.";
                                StartCoroutine(Wait());
                                PageCount++;
                                break;
                            }
				case 2:
					{
						collider.gameObject.SetActive(false);
						PageBG.SetActive(true);
						Page.text = "Arbiter suit model #3112 manual \n" +
							"An introduction: your suit and you pt1\n" +
							"Thank you for purchasing our product Arbiter suit model #3112 this part" +
							" of the manual will introduce you to the basic functions of this product.\n" +
							"Arbiter suit model #3112 is equipped with a standard issue Remington pistol model #41200 which comes equipped with a laser sight, standard automatic fire" +
							" and alternate shotgun fire with the pistol having a clip size of ten bullets.\n" +
							"(Disclaimer: Mann Co. guns can kill almost all unshielded personal, with the exceptions of sentry robots and bandit/robbers/criminal leader," +
							" Mann Co. is currently working to iron out those bugs).  ";
						StartCoroutine(Wait());
						PageCount++;
						break;
					}
				case 3:
					{
						collider.gameObject.SetActive(false);
						PageBG.SetActive(true);
						Page.text = "Arbiter suit model #3112 manual \n" +
						"An introduction: your suit and you pt2\n" +
						"The Arbiter suit it self comes equipped with a shield that can protect the wilder from almost all damage  (Mann Co. does not endorse users to put them selves at risk while wearing the suit," +
						" Mann Co. is not Responsible for any injuries the user takes while wear the suit).\n" +
						"(Warning the suits shield is not invincible, it does have a set durability)\n" +
						"Lastly the Arbiter suit comes with a helmet that has a head mounted display, linking with (Mann Co.) guns and shields showing the" +
						" user how many bullets the have left and how much durability the shield has left. ";
						StartCoroutine(Wait());
						PageCount++;
						break;
					}

				case 4:
					{
						collider.gameObject.SetActive(false);
						PageBG.SetActive(true);
						Page.text = "Personal log Entry#340\n" +
						"Shariff: Johnathan Doeff\n" +
						"Date: Wed, Feb 20 30##\n" +
						"The outpost has been attacked buy bandits, they came like a storm fast and destructive," +
						" no one was spared, the bandits killed everyone the came across.\n" +
						"Even my wife… at least it was painless.\n" +
						"I didn’t even know how they did it but they some how hacked the towns sentry robots," +
						" using them to shoot down everyone that wasn’t them.\n" +
						"I didn’t know how they did it, that was until I saw it, a person in an arbiter suit shouting commands at the bandits.\n" +
						"No one was supposed to have a arbiter suit unless they where a sheriff," +
						" than it hit me the sheriff that went missing, that bastard went rouge!\n" +
						"I tried to shot him down but before I could the world went black.\n" +
						"When I came to the town had turned into a ghost town.";
						StartCoroutine(Wait());
						PageCount++;
						break;
					}
				case 5:
					{
						collider.gameObject.SetActive(false);
						PageBG.SetActive(true);
						Page.text = "Personal log Entry#670\n" +
						"Shariff: Johnathan Doeff\n" +
						"Date: Wed, Feb 20 30##\n" +
						"I don’t even know why I write in this thing anymore maybe it’s" +
						" because it’s a reminder of when things weren’t shit, life was slow but fuck all happened.\n" +
						"I’ve been tracking the bastards who killed my wife and burnt the outpost down.\n" +
						"News form my sources finally came that after causing hell for the whole planet the" +
						" law finally decided to come down on them.\n" +
						"Being pushed back they decided to lay low at the site of their first big crime , the outpost, and look at that its also the anniversary of when they killed my wife, I can only think it’s fate that all these things lined up," +
						" something out there maybe god, giving me another chance to bring them to justice.\n";
							StartCoroutine(Wait());
						PageCount++;
						break;
					}
                    }
                    break;
                    
                }
                
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
        PageBG.SetActive(false);
    }
}
