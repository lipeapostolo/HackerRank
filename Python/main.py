def swap_case(s):
    nova_frase = ""
    for l in s:
        if l.isupper() :
            nova_frase += l.lower() 
        else :
            nova_frase += l.upper()
          
    return nova_frase

if __name__ == '__main__':
    s = input()
    result = swap_case(s)
    print(result)