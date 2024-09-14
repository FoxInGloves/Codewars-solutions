export const encryptThis = (str: string): string => {
    if (str.length < 1) return str;
    let words = str.split(' ');
    for (let i = 0; i < words.length; i++) {
        if (words[i].length > 2) {
            let temp: string = words[i][1];
            words[i] = replaceChar(words[i], 1, words[i][words[i].length - 1]);
            words[i] = replaceChar(words[i], words[i].length - 1, temp)
        }
        words[i] = replaceChar(words[i], 0, words[i].charCodeAt(0).toString())
    }
    return words.join(' ');
}

function replaceChar(str: string, index: number, char: string): string {
    let chars: string[] = Array.from(str);
    chars.splice(index, 1, char);
    return chars.join('');
}